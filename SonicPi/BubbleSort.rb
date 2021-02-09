use_bpm 90



unsorted_array = [20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35]

with_fx :reverb, room: 1 do
  
  live_loop :sort do
    
    bubble_sort unsorted_array
    
  end
  
end


def bubble_sort array
  
  arr = array.dup
  
  swapped = false
  
  len = arr.length - 2
  
  
  total_swaps = 0
  total_iters = 0
  swaps_per_iter = []
  array_states = []
  
  
  arr.each { |n| play n; sleep 0.25 }
  
  
  while true do
      
      swaps = 0
      
      total_iters += 1
      
      
      in_thread do
        
        use_synth :cnoise 
        
        play 52, amp: 0.5, attack: 2, sustain: 6, decay: 2, release: 4, cutoff: 60
        
        sample :bd_pure 
        
      end
      
      
      in_thread do
        
        total_iters.times do |i|
          
          sample :ambi_piano, amp: 1.0 + (i.to_f / 2.0), rate: 2
          
          sleep (2.0 / total_iters).round(2)
          
        end
        
      end
      
      
      for i in 0..len
        
        play arr[i], release: 0.1
        
        sleep 0.25
        
        if arr[i] > arr[i+1]
          
          arr[i], arr[i+1] = arr[i+1], arr[i]
          
          swapped = true if !swapped
          
          sample :elec_flip, amp: 1.5
          
          sleep 0.25
          
          play arr[i] 
          
          sleep 0.25
          
          swaps += 1
          
        end
        
      end
      
      total_swaps += swaps
      
      swaps_per_iter.push(swaps)
      
      swapped ? swapped = false : break
      
      array_states.push(arr.dup)
      
    end
    
    sorted arr
    
    [arr, total_swaps, swaps_per_iter, total_iters, array_states]
    
  end
  
  
  def sorted array
    
    4.times do
      
      in_thread do
        
        array.each { |n|
          
          play n, release: 0.1
          
          sleep 0.25
          
        }
        
      end
      
      in_thread do 
        
        sample :bd_tek
        
        sleep 16
        
      end
      
      sample :loop_breakbeat, beat_stretch: 4, amp: 2
      
      sleep 4
      
    end
    
  end
  
  
  
  
  
  
  
  