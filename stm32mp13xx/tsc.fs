\
\ @file tsc.fs
\ @brief TSC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Touch sensing controller enable This bit is set and cleared by software to enable/disable the touch sensing controller. Note: When the touch sensing controller is disabled, TSC registers settings have no effect.
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TSC_TSC_CR_TSCE                                  \ Touch sensing controller enable This bit is set and cleared by software to enable/disable the touch sensing controller. Note: When the touch sensing controller is disabled, TSC registers settings have no effect.
$00000002 constant TSC_TSC_CR_START                                 \ Start a new acquisition This bit is set by software to start a new acquisition. It is cleared by hardware as soon as the acquisition is complete or by software to cancel the ongoing acquisition.
$00000004 constant TSC_TSC_CR_AM                                    \ Acquisition mode This bit is set and cleared by software to select the acquisition mode. Note: This bit must not be modified when an acquisition is ongoing.
$00000008 constant TSC_TSC_CR_SYNCPOL                               \ Synchronization pin polarity This bit is set and cleared by software to select the polarity of the synchronization input pin.
$00000010 constant TSC_TSC_CR_IODEF                                 \ I/O Default mode This bit is set and cleared by software. It defines the configuration of all the TSC I/Os when there is no ongoing acquisition. When there is an ongoing acquisition, it defines the configuration of all unused I/Os (not defined as sampling capacitor I/O or as channel I/O). Note: This bit must not be modified when an acquisition is ongoing.
$000000e0 constant TSC_TSC_CR_MCV                                   \ Max count value These bits are set and cleared by software. They define the maximum number of charge transfer pulses that can be generated before a max count error is generated. Note: These bits must not be modified when an acquisition is ongoing.
$00007000 constant TSC_TSC_CR_PGPSC                                 \ Pulse generator prescaler These bits are set and cleared by software.They select the AHB clock divider used to generate the pulse generator clock (PGCLK). Note: These bits must not be modified when an acquisition is ongoing. Note: Some configurations are forbidden. Refer to the acquisition sequence for details.
$00008000 constant TSC_TSC_CR_SSPSC                                 \ Spread spectrum prescaler This bit is set and cleared by software. It selects the AHB clock divider used to generate the spread spectrum clock (SSCLK). Note: This bit must not be modified when an acquisition is ongoing.
$00010000 constant TSC_TSC_CR_SSE                                   \ Spread spectrum enable This bit is set and cleared by software to enable/disable the spread spectrum feature. Note: This bit must not be modified when an acquisition is ongoing.
$00fe0000 constant TSC_TSC_CR_SSD                                   \ Spread spectrum deviation These bits are set and cleared by software. They define the spread spectrum deviation which consists in adding a variable number of periods of the SSCLK clock to the charge transfer pulse high state. ... Note: These bits must not be modified when an acquisition is ongoing.
$0f000000 constant TSC_TSC_CR_CTPL                                  \ Charge transfer pulse low These bits are set and cleared by software. They define the duration of the low state of the charge transfer pulse (transfer of charge from CX to CS). ... Note: These bits must not be modified when an acquisition is ongoing. Note: Some configurations are forbidden. Refer to the acquisition sequence for details.
$f0000000 constant TSC_TSC_CR_CTPH                                  \ Charge transfer pulse high These bits are set and cleared by software. They define the duration of the high state of the charge transfer pulse (charge of CX). ... Note: These bits must not be modified when an acquisition is ongoing.


\
\ @brief End of acquisition interrupt enable This bit is set and cleared by software to enable/disable the end of acquisition interrupt.
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TSC_TSC_IER_EOAIE                                \ End of acquisition interrupt enable This bit is set and cleared by software to enable/disable the end of acquisition interrupt.
$00000002 constant TSC_TSC_IER_MCEIE                                \ Max count error interrupt enable This bit is set and cleared by software to enable/disable the max count error interrupt.


\
\ @brief End of acquisition interrupt clear This bit is set by software to clear the end of acquisition flag and it is cleared by hardware when the flag is reset. Writing a '0â has no effect.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant TSC_TSC_ICR_EOAIC                                \ End of acquisition interrupt clear This bit is set by software to clear the end of acquisition flag and it is cleared by hardware when the flag is reset. Writing a '0â has no effect.
$00000002 constant TSC_TSC_ICR_MCEIC                                \ Max count error interrupt clear This bit is set by software to clear the max count error flag and it is cleared by hardware when the flag is reset. Writing a '0â has no effect.


\
\ @brief End of acquisition flag This bit is set by hardware when the acquisition of all enabled group is complete (all GxS bits of all enabled analog I/O groups are set or when a max count error is detected). It is cleared by software writing 1 to the bit EOAIC of the TSC_ICR register.
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TSC_TSC_ISR_EOAF                                 \ End of acquisition flag This bit is set by hardware when the acquisition of all enabled group is complete (all GxS bits of all enabled analog I/O groups are set or when a max count error is detected). It is cleared by software writing 1 to the bit EOAIC of the TSC_ICR register.
$00000002 constant TSC_TSC_ISR_MCEF                                 \ Max count error flag This bit is set by hardware as soon as an analog I/O group counter reaches the max count value specified. It is cleared by software writing 1 to the bit MCEIC of the TSC_ICR register.


\
\ @brief null
\ Address offset: 0x10
\ Reset value: 0xFFFFFFFF
\

$00000001 constant TSC_TSC_IOHCR_G1_IO1                         
$00000002 constant TSC_TSC_IOHCR_G1_IO2                         
$00000004 constant TSC_TSC_IOHCR_G1_IO3                         
$00000008 constant TSC_TSC_IOHCR_G1_IO4                         
$00000010 constant TSC_TSC_IOHCR_G2_IO1                         
$00000020 constant TSC_TSC_IOHCR_G2_IO2                         
$00000040 constant TSC_TSC_IOHCR_G2_IO3                         
$00000080 constant TSC_TSC_IOHCR_G2_IO4                         
$00000100 constant TSC_TSC_IOHCR_G3_IO1                         
$00000200 constant TSC_TSC_IOHCR_G3_IO2                         
$00000400 constant TSC_TSC_IOHCR_G3_IO3                         
$00000800 constant TSC_TSC_IOHCR_G3_IO4                         
$00001000 constant TSC_TSC_IOHCR_G4_IO1                         
$00002000 constant TSC_TSC_IOHCR_G4_IO2                         
$00004000 constant TSC_TSC_IOHCR_G4_IO3                         
$00008000 constant TSC_TSC_IOHCR_G4_IO4                         
$00010000 constant TSC_TSC_IOHCR_G5_IO1                         
$00020000 constant TSC_TSC_IOHCR_G5_IO2                         
$00040000 constant TSC_TSC_IOHCR_G5_IO3                         
$00080000 constant TSC_TSC_IOHCR_G5_IO4                         


\
\ @brief null
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant TSC_TSC_IOASCR_G1_IO1                        
$00000002 constant TSC_TSC_IOASCR_G1_IO2                        
$00000004 constant TSC_TSC_IOASCR_G1_IO3                        
$00000008 constant TSC_TSC_IOASCR_G1_IO4                        
$00000010 constant TSC_TSC_IOASCR_G2_IO1                        
$00000020 constant TSC_TSC_IOASCR_G2_IO2                        
$00000040 constant TSC_TSC_IOASCR_G2_IO3                        
$00000080 constant TSC_TSC_IOASCR_G2_IO4                        
$00000100 constant TSC_TSC_IOASCR_G3_IO1                        
$00000200 constant TSC_TSC_IOASCR_G3_IO2                        
$00000400 constant TSC_TSC_IOASCR_G3_IO3                        
$00000800 constant TSC_TSC_IOASCR_G3_IO4                        
$00001000 constant TSC_TSC_IOASCR_G4_IO1                        
$00002000 constant TSC_TSC_IOASCR_G4_IO2                        
$00004000 constant TSC_TSC_IOASCR_G4_IO3                        
$00008000 constant TSC_TSC_IOASCR_G4_IO4                        
$00010000 constant TSC_TSC_IOASCR_G5_IO1                        
$00020000 constant TSC_TSC_IOASCR_G5_IO2                        
$00040000 constant TSC_TSC_IOASCR_G5_IO3                        
$00080000 constant TSC_TSC_IOASCR_G5_IO4                        


\
\ @brief null
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant TSC_TSC_IOCCR_G1_IO1                         
$00000002 constant TSC_TSC_IOCCR_G1_IO2                         
$00000004 constant TSC_TSC_IOCCR_G1_IO3                         
$00000008 constant TSC_TSC_IOCCR_G1_IO4                         
$00000010 constant TSC_TSC_IOCCR_G2_IO1                         
$00000020 constant TSC_TSC_IOCCR_G2_IO2                         
$00000040 constant TSC_TSC_IOCCR_G2_IO3                         
$00000080 constant TSC_TSC_IOCCR_G2_IO4                         
$00000100 constant TSC_TSC_IOCCR_G3_IO1                         
$00000200 constant TSC_TSC_IOCCR_G3_IO2                         
$00000400 constant TSC_TSC_IOCCR_G3_IO3                         
$00000800 constant TSC_TSC_IOCCR_G3_IO4                         
$00001000 constant TSC_TSC_IOCCR_G4_IO1                         
$00002000 constant TSC_TSC_IOCCR_G4_IO2                         
$00004000 constant TSC_TSC_IOCCR_G4_IO3                         
$00008000 constant TSC_TSC_IOCCR_G4_IO4                         
$00010000 constant TSC_TSC_IOCCR_G5_IO1                         
$00020000 constant TSC_TSC_IOCCR_G5_IO2                         
$00040000 constant TSC_TSC_IOCCR_G5_IO3                         
$00080000 constant TSC_TSC_IOCCR_G5_IO4                         


\
\ @brief null
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant TSC_TSC_IOGCSR_G1E                           
$00000002 constant TSC_TSC_IOGCSR_G2E                           
$00000004 constant TSC_TSC_IOGCSR_G3E                           
$00000008 constant TSC_TSC_IOGCSR_G4E                           
$00000010 constant TSC_TSC_IOGCSR_G5E                           
$00010000 constant TSC_TSC_IOGCSR_G1S                           
$00020000 constant TSC_TSC_IOGCSR_G2S                           
$00040000 constant TSC_TSC_IOGCSR_G3S                           
$00080000 constant TSC_TSC_IOGCSR_G4S                           
$00100000 constant TSC_TSC_IOGCSR_G5S                           


\
\ @brief Counter value
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00003fff constant TSC_TSC_IOG1CR_CNT                               \ Counter value


\
\ @brief Counter value
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00003fff constant TSC_TSC_IOG2CR_CNT                               \ Counter value


\
\ @brief Counter value
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00003fff constant TSC_TSC_IOG3CR_CNT                               \ Counter value


\
\ @brief Counter value
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00003fff constant TSC_TSC_IOG4CR_CNT                               \ Counter value


\
\ @brief TSC hardware configuration 1 These bits return the TSP CFG1[3:0] configuration. CFG1[3:0] = group_size = 0x5 (group size).
\ Address offset: 0x3F0
\ Reset value: 0x00000025
\

$0000000f constant TSC_TSC_HWCFGR_CFG1                              \ TSC hardware configuration 1 These bits return the TSP CFG1[3:0] configuration. CFG1[3:0] = group_size = 0x5 (group size).
$000000f0 constant TSC_TSC_HWCFGR_CFG2                              \ TSC hardware configuration 2 These bits return the TSP CFG2[3:0] configuration. CFG2[3:0] = dt_duration = 0x2 (dead time duration).


\
\ @brief Minor revision These bits return the TSC minor revision. MINREV[3:0] = 0x2
\ Address offset: 0x3F4
\ Reset value: 0x00000012
\

$0000000f constant TSC_TSC_VERR_MINREV                              \ Minor revision These bits return the TSC minor revision. MINREV[3:0] = 0x2
$000000f0 constant TSC_TSC_VERR_MAJREV                              \ Major revision These bits return the TSC major revision. MAJREV[3:0] = 0x1


\
\ @brief TSC identifier These bits return the TSC identifier. ID[31:0] = 0x00110041
\ Address offset: 0x3F8
\ Reset value: 0x00110041
\

$00000000 constant TSC_TSC_IDR_ID                                   \ TSC identifier These bits return the TSC identifier. ID[31:0] = 0x00110041


\
\ @brief TSC size identification These bits return the size of the memory region allocated to the TSC registers. SID[31:0] = 0xA3C5DD01
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant TSC_TSC_SIDR_SID                                 \ TSC size identification These bits return the size of the memory region allocated to the TSC registers. SID[31:0] = 0xA3C5DD01


\
\ @brief TSC
\
$5000b000 constant TSC_TSC_CR     \ offset: 0x00 : Touch sensing controller enable This bit is set and cleared by software to enable/disable the touch sensing controller. Note: When the touch sensing controller is disabled, TSC registers settings have no effect.
$5000b004 constant TSC_TSC_IER    \ offset: 0x04 : End of acquisition interrupt enable This bit is set and cleared by software to enable/disable the end of acquisition interrupt.
$5000b008 constant TSC_TSC_ICR    \ offset: 0x08 : End of acquisition interrupt clear This bit is set by software to clear the end of acquisition flag and it is cleared by hardware when the flag is reset. Writing a '0â has no effect.
$5000b00c constant TSC_TSC_ISR    \ offset: 0x0C : End of acquisition flag This bit is set by hardware when the acquisition of all enabled group is complete (all GxS bits of all enabled analog I/O groups are set or when a max count error is detected). It is cleared by software writing 1 to the bit EOAIC of the TSC_ICR register.
$5000b010 constant TSC_TSC_IOHCR  \ offset: 0x10 : null
$5000b018 constant TSC_TSC_IOASCR  \ offset: 0x18 : null
$5000b028 constant TSC_TSC_IOCCR  \ offset: 0x28 : null
$5000b030 constant TSC_TSC_IOGCSR  \ offset: 0x30 : null
$5000b034 constant TSC_TSC_IOG1CR  \ offset: 0x34 : Counter value
$5000b038 constant TSC_TSC_IOG2CR  \ offset: 0x38 : Counter value
$5000b03c constant TSC_TSC_IOG3CR  \ offset: 0x3C : Counter value
$5000b040 constant TSC_TSC_IOG4CR  \ offset: 0x40 : Counter value
$5000b3f0 constant TSC_TSC_HWCFGR  \ offset: 0x3F0 : TSC hardware configuration 1 These bits return the TSP CFG1[3:0] configuration. CFG1[3:0] = group_size = 0x5 (group size).
$5000b3f4 constant TSC_TSC_VERR   \ offset: 0x3F4 : Minor revision These bits return the TSC minor revision. MINREV[3:0] = 0x2
$5000b3f8 constant TSC_TSC_IDR    \ offset: 0x3F8 : TSC identifier These bits return the TSC identifier. ID[31:0] = 0x00110041
$5000b3fc constant TSC_TSC_SIDR   \ offset: 0x3FC : TSC size identification These bits return the size of the memory region allocated to the TSC registers. SID[31:0] = 0xA3C5DD01

